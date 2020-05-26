using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BLL.DTO;
using BLL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;

namespace BLL.Services
{
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public OrderService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task CreateOrder(ICollection<PartDTO> partsForReplacement, decimal price)
        {

            try
            {
                IsRepairable(partsForReplacement);
            }
            catch
            {
                return;
            }

            var order = new OrderDTO() { PartsForReplacement = partsForReplacement, Price = price, Date = DateTime.Now };
            foreach (var part in partsForReplacement)
            {
                part.OrderId = order.Id;
            }
            var orderEntity = _mapper.Map<Order>(order);
            await _unitOfWork.OrderRepository.Create(orderEntity);
            await _unitOfWork.Save();
        }

        private void IsRepairable(IEnumerable<PartDTO> partsForReplacement)
        {
            if (!partsForReplacement.Select(p => p.PartName).Except(_unitOfWork.PartRepository.GetAll().Select(a => a.PartName)).Any())
            {
                return;
            }
            throw new ArgumentException("Недостатньо деталей");

        }
    }
}
