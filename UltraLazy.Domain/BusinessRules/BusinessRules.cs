using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraLazy.Domain.BusinessRules
{
    public interface IBusinessRule
    {
        bool Validate();
    }
}
