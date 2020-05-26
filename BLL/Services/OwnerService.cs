using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BLL.DTO;
using BLL.Interfaces;
using DAL.Interfaces;

namespace BLL.Services
{
    public class OwnerService:IOwnerService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public OwnerService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IEnumerable<OwnerDTO> Find(string name)
        {
            var owners =_unitOfWork.OwnerRepository.GetAll().Where(o => o.Name.Equals(name)).ToList();
            return _mapper.Map<IEnumerable<OwnerDTO>>(owners);
        }

        public IEnumerable<OwnerDTO> FindByPartName(string name)
        {
            var owners = _unitOfWork.OrderRepository.GetAll()
                .Where(o => o.PartsForReplacement.Select(p => p.PartName).Any(x=> x.Equals(name))).Select(o =>o.Owner);
            return _mapper.Map<IEnumerable<OwnerDTO>>(owners);
        }

        public OwnerDTO Find(int OrderId)
        {
            var owner = _unitOfWork.OrderRepository.GetAll().Where(o => o.Id == OrderId).Select(o => o.Owner).FirstOrDefault();
            return _mapper.Map<OwnerDTO>(owner);
        }

        public IEnumerable<OwnerDTO> Find(DateTime date)
        {
            var owner = _unitOfWork.OrderRepository.GetAll().Where(o => o.Date == date).Select(o => o.Owner);
            return _mapper.Map<IEnumerable<OwnerDTO>>(owner);
        }

        public IEnumerable<OwnerDTO> FindByComputerModel(string name)
        {
            var owner = _unitOfWork.OwnerRepository.GetAll().Where(o => o.Computers.Any(c => c.ModelName.Equals(name)));
            return _mapper.Map<IEnumerable<OwnerDTO>>(owner);
        }

        public IEnumerable<OwnerDTO> GetAll()
        {
            return _mapper.Map<IEnumerable<OwnerDTO>>(_unitOfWork.OwnerRepository.GetAll().ToList());
        }
    }
}