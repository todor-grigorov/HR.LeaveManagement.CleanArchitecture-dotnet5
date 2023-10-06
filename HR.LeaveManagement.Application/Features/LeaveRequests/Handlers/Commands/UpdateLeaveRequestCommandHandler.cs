using AutoMapper;
using HR.LeaveManagement.Application.Features.LeaveRequests.Requests.Commands;
using HR.LeaveManagement.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveRequests.Handlers.Commands
{
    public class UpdateLeaveRequestCommandHandler : IRequestHandler<UpdateLeaveRequestCommand, Unit>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;

        public UpdateLeaveRequestCommandHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
        {
            this._leaveRequestRepository = leaveRequestRepository;
            this._mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            if (request.LeaveRequestDto != null)
            {
                var leaveReuqest = await _leaveRequestRepository.Get(request.LeaveRequestDto.Id);

                _mapper.Map(request.LeaveRequestDto, leaveReuqest);

                await _leaveRequestRepository.Update(leaveReuqest);
            }
            else if (request.ChangeLeaveRequestApprovalDto != null)
            {

            }

            return Unit.Value;
        }
    }
}
