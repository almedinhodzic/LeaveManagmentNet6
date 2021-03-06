using AutoMapper;
using LeaveManagment.Web.Constants;
using LeaveManagment.Web.Contracts;
using LeaveManagment.Web.Data;
using LeaveManagment.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagment.Web.Repositories
{
    public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<Employee> userManager;
        private readonly ILeaveTypeRepository leaveTypeRepository;
        private readonly IMapper mapper;

        public LeaveAllocationRepository(
            ApplicationDbContext context, 
            UserManager<Employee> userManager,
            ILeaveTypeRepository leaveTypeRepository,
            IMapper mapper) : base(context)
        {
            this.context = context;
            this.userManager = userManager;
            this.leaveTypeRepository = leaveTypeRepository;
            this.mapper = mapper;
        }

        public async Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period)
        {
            return await context.leaveAllocations.AnyAsync(
                q => q.EmployeeId == employeeId && q.LeaveTypeId == leaveTypeId && q.Period == period
            );
        }

        public async Task<EmployeeAllocationVM> GetEmployeeAllocations(string id)
        {
            var allocations = await context.leaveAllocations
                .Include(q => q.LeaveType)
                .Where(q => q.EmployeeId == id).ToListAsync();
            var employee = await userManager.FindByIdAsync(id);
            var employeeAllocationModel = mapper.Map<EmployeeAllocationVM>(employee);
            employeeAllocationModel.LeaveAllocations = mapper.Map<List<LeaveAllocationVM>>(allocations);

            return employeeAllocationModel;
        }

        public async Task<EmployeeAllocationEditVM> GetEmployeeAllocation(int id)
        {
            var allocation = await context.leaveAllocations
                .Include(q => q.LeaveType)
                .FirstOrDefaultAsync(q => q.Id == id);

            if (allocation == null)
            {
                return null;
            }

            var employee = await userManager.FindByIdAsync(allocation.EmployeeId);
            var model = mapper.Map<EmployeeAllocationEditVM>(allocation);
            model.Employee = mapper.Map<EmployeeListVM>(await userManager.FindByIdAsync(allocation.EmployeeId));
            return model;
        }

        public async Task LeaveAllocation(int leaveTypeId)
        {
            var employees = await userManager.GetUsersInRoleAsync(Roles.User);
            int period = DateTime.Now.Year;
            var leaveType = await leaveTypeRepository.GetAsync(leaveTypeId);
            var allocations = new List<LeaveAllocation>();

            foreach (var employee in employees)
            {
                if(await AllocationExists(employee.Id, leaveTypeId, period))
                {
                    continue;
                };
                var allocation = new LeaveAllocation
                {
                    EmployeeId = employee.Id,
                    LeaveTypeId = leaveTypeId,
                    Period = period,
                    NumberOfDays = leaveType.DefaultDays
                };
                allocations.Add(allocation);
            }

            await AddRangeAsync(allocations);
        }

        public async Task<bool> UpdateEmployeeAllocation(EmployeeAllocationEditVM model)
        {
            var leaveAllocation = await GetAsync(model.Id);
            if (leaveAllocation == null)
            {
                return false;
            }
            leaveAllocation.Period = model.Period;
            leaveAllocation.NumberOfDays = model.NumberOfDays;
            await UpdateAsync(leaveAllocation);

            return true;
        }
    }
}
