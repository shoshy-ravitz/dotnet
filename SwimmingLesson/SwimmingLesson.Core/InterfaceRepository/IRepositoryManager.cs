using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingLesson.Core.InterfaceRepository
{
    public interface IRepositoryManager <T> where T : class
    {
        void save();
    }
}
