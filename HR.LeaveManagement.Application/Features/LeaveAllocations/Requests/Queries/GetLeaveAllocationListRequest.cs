using HR.LeaveManagement.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagement.Application.Features.LeaveAlocations.Requests.Queries
{
    public class GetLeaveAlocationListRequest : IRequest<List<LeaveAllocationDto>>
    {
    }
}
