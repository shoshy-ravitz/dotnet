using SwimmingLesson.Core.InterfaceRepository;
using SwimmingLesson.Core.InterfaceService;
using SwimmingLesson.Data.Repository;
using SwimmingLessons.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingLesson.Service.Services
{
    public class GuideService : IGuideService
    {
        readonly IRepository<Guide> _guideRepository;
        readonly IRepositoryManager<Guide> _repositoryManager;
        public GuideService(IRepository<Guide> guideRepository, IRepositoryManager<Guide> repositoryManager)
        {
            _guideRepository = guideRepository;
            _repositoryManager = repositoryManager;
        }
        public bool AddGuide(Guide guide)
        {
            bool res= _guideRepository.Add(guide);
            _repositoryManager.save();
            return res;
        }
        public bool DeleteGuide(int guideId)
        {
            bool res= (_guideRepository.Delete(guideId));
            _repositoryManager.save();
            return res;
        }

        public Guide GetGuideByCode(int guideId)
        {
            return _guideRepository.GetByCode(guideId);
        }

        public List<Guide> GetGuides()
        {
            return _guideRepository.Get();
        }
        public bool UpdateGuide(int guideId, Guide guide)
        {
            bool res= _guideRepository.Update(guideId, guide);
            _repositoryManager.save();
            return res;
        }
    }
}
