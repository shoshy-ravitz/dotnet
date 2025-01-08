using SwimmingLessons.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingLesson.Core.InterfaceRepository
{
    public interface IGuideRepositiry
    {

        public List<Guide> GetGuides();
        public Guide GetGuideByCode(int guideId);
        public bool AddGuide(Guide guide);
        public bool UpdateGuide(int guideId, Guide guide);
        public bool DeleteGuide(int guideId);

    }
}
