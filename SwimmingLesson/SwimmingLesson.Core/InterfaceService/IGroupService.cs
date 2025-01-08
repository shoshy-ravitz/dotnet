using SwimmingLessons.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingLesson.Core.InterfaceService
{
    public interface IGroupService
    {
        public List<Group> GetGroups();
        public Group GetGroupByCode(int codeGroup);
        public bool AddGroup(Group group);
        public bool UpdateGroup(int groupId, Group group);
        public bool DeleteGroup(int codeGroup);
    }
}
