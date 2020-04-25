using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BLL.DTO;
using BLL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;

namespace BLL.Services
{
    public class PartService:IPartService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PartService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public PartDTO Find(string name)
        {
            var part = _unitOfWork.PartRepository.GetAll().FirstOrDefault(p => p.PartName.Equals(name));
            return _mapper.Map<PartDTO>(part);
        }

        public PartDTO Find(DateTime date)
        {
            var part = _unitOfWork.PartRepository.GetAll().FirstOrDefault(p => p.DateOfCreation.Equals(date));
            return _mapper.Map<PartDTO>(part);
        }

        public async Task<IEnumerable<PartDTO>> Find(int orderId)
        {
            var order = await _unitOfWork.OrderRepository.GetById(orderId);
            var parts = order.PartsForReplacement;
            return _mapper.Map<IEnumerable<PartDTO>>(parts);
        }
    }
}