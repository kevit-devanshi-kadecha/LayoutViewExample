using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceContracts;

namespace Services 
{
    public class SalaryService : ISalaryService
    {
        private List<int> _salaries;

        private Guid _SalaryId;
        public Guid SalaryId 
        {
            get
            {
                return _SalaryId;
            }
        }
        public SalaryService()
        {
            _SalaryId = Guid.NewGuid();
            _salaries = new List<int>() {
                75000,   
                80000,   
                70000    
            };
        }
        public Guid GetId() 
        { 
            return _SalaryId;
        }

        public List<int> GetSalaries()
        {
            return _salaries;
        }
    }
}
