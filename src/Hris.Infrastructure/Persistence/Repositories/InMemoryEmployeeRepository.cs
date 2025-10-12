using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Hris.Application.Interfaces.Repositories;
using Hris.Domain.Entities;

namespace Hris.Infrastructure.Persistence.Repositories;

public class InMemoryEmployeeRepository : IEmployeeRepository
{
    private readonly List<Employee> _employees;

    public InMemoryEmployeeRepository()
    {
        _employees = BuildSeedData();
    }

    public Task AddAsync(Employee employee, CancellationToken cancellationToken = default)
    {
        _employees.Add(employee);
        return Task.CompletedTask;
    }

    public Task<IReadOnlyCollection<Employee>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        IReadOnlyCollection<Employee> result = _employees.AsReadOnly();
        return Task.FromResult(result);
    }

    public Task<Employee?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var employee = _employees.FirstOrDefault(e => e.Id == id);
        return Task.FromResult(employee);
    }

    private static List<Employee> BuildSeedData()
    {
        var now = DateTime.UtcNow;
        var seeds = new (string Number, string Name, string Department, string Position, string Status, int MonthsAgo)[]
        {
            ("HR-0001", "Chanon Phumiphak", "People Operations", "HR Business Partner", "Active", 60),
            ("HR-0002", "Supaporn Teerapat", "People Operations", "Compensation Lead", "Active", 72),
            ("HR-0003", "Kanokwan Yodying", "People Operations", "Recruitment Specialist", "Active", 24),
            ("HR-0004", "Phavinee Chongrak", "People Operations", "HRIS Analyst", "Active", 30),
            ("HR-0005", "Pattarapon Sri", "People Operations", "Learning Partner", "On Leave", 18),
            ("HR-0006", "Nattanee Nopparat", "People Operations", "Employer Branding Specialist", "Active", 12),
            ("HR-0007", "Jutarat Mensiri", "People Operations", "HR Coordinator", "Probation", 4),
            ("HR-0008", "Apisara Suksan", "People Operations", "Compensation Analyst", "Active", 20),
            ("IT-0001", "Anuwat Khem", "Technology", "Chief Technology Officer", "Active", 96),
            ("IT-0002", "Rinrada Kongkun", "Technology", "Engineering Manager", "Active", 84),
            ("IT-0003", "Thanawat Dee", "Technology", "Senior Backend Engineer", "Active", 60),
            ("IT-0004", "Sirinya Pairat", "Technology", "Senior Frontend Engineer", "Active", 54),
            ("IT-0005", "Pisit Chansuk", "Technology", "DevOps Engineer", "Active", 42),
            ("IT-0006", "Rawin Phromsir", "Technology", "QA Lead", "Active", 36),
            ("IT-0007", "Suphicha Lertsiri", "Technology", "QA Analyst", "Active", 18),
            ("IT-0008", "Nawapol Klahan", "Technology", "Data Engineer", "Active", 28),
            ("IT-0009", "Warit Somchai", "Technology", "Product Manager", "Active", 26),
            ("IT-0010", "Patchara Tianchai", "Technology", "UX Researcher", "Active", 22),
            ("IT-0011", "Anucha Bunkhun", "Technology", "Mobile Engineer", "Active", 16),
            ("IT-0012", "Thidarat Kwan", "Technology", "Frontend Engineer", "Probation", 3),
            ("IT-0013", "Saharat Techasiri", "Technology", "Security Engineer", "Active", 14),
            ("IT-0014", "Kamonnut Ratri", "Technology", "Scrum Master", "Active", 32),
            ("FN-0001", "Nattawat Charoen", "Finance", "Payroll Specialist", "On Leave", 24),
            ("FN-0002", "Benjamas Sriwilai", "Finance", "Finance Manager", "Active", 72),
            ("FN-0003", "Sineenart Laong", "Finance", "Senior Accountant", "Active", 55),
            ("FN-0004", "Kritsadaporn Meechai", "Finance", "Accounts Receivable Analyst", "Active", 20),
            ("FN-0005", "Narin Klaisong", "Finance", "Accounts Payable Analyst", "Active", 18),
            ("FN-0006", "Prapasri Jongjit", "Finance", "Treasury Analyst", "Active", 26),
            ("MK-0001", "Oranicha Mek", "Marketing", "Marketing Lead", "Active", 40),
            ("MK-0002", "Chalita Rungjit", "Marketing", "Campaign Manager", "Active", 34),
            ("MK-0003", "Thanida Lek", "Marketing", "Content Strategist", "Active", 28),
            ("MK-0004", "Suwit Phasuk", "Marketing", "Digital Analyst", "Active", 16),
            ("MK-0005", "Chanika Meechai", "Marketing", "Graphic Designer", "Active", 14),
            ("MK-0006", "Ekkachai Roong", "Marketing", "Marketing Coordinator", "Probation", 2),
            ("CS-0001", "Jirawat Kan", "Customer Success", "Customer Success Lead", "Active", 45),
            ("CS-0002", "Supawadee Ornnapa", "Customer Success", "Implementation Manager", "Active", 42),
            ("CS-0003", "Ratchapol Namchai", "Customer Success", "Onboarding Specialist", "Active", 18),
            ("CS-0004", "Kamonchanok Dee", "Customer Success", "Support Specialist", "Active", 12),
            ("CS-0005", "Tawan Limpin", "Customer Success", "Renewal Manager", "Active", 30),
            ("OP-0001", "Amara Jittrakorn", "Operations", "Operations Director", "Active", 80),
            ("OP-0002", "Phawat Somsak", "Operations", "Facilities Manager", "Active", 50),
            ("OP-0003", "Sasiwimol Kiat", "Operations", "Procurement Lead", "Active", 36),
            ("OP-0004", "Prasert Wongpan", "Operations", "Logistics Coordinator", "Active", 18),
            ("OP-0005", "Wimonkan Sornchai", "Operations", "Office Administrator", "Active", 10),
            ("SL-0001", "Pimchanok Rukdee", "Sales", "Sales Director", "Active", 68),
            ("SL-0002", "Kamonchan Artit", "Sales", "Account Executive", "Active", 18),
            ("SL-0003", "Apichat Kaew", "Sales", "Sales Operations Analyst", "Active", 12),
            ("DA-0001", "Piyada Sornchai", "Data & Analytics", "Head of Analytics", "Active", 48),
            ("DA-0002", "Natdanai Yongyut", "Data & Analytics", "Data Analyst", "Active", 22),
            ("DA-0003", "Sirilak Mintra", "Data & Analytics", "BI Developer", "Active", 18)
        };

        return seeds
            .Select(seed => new Employee
            {
                Id = CreateGuid(seed.Number),
                EmployeeNumber = seed.Number,
                FullName = seed.Name,
                Department = seed.Department,
                Position = seed.Position,
                Status = seed.Status,
                HiredAt = now.AddMonths(-seed.MonthsAgo)
            })
            .ToList();
    }

    private static Guid CreateGuid(string input)
    {
        using var md5 = MD5.Create();
        var bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
        return new Guid(bytes);
    }
}
