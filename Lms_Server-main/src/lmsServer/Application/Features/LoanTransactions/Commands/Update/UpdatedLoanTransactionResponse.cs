using NArchitecture.Core.Application.Responses;

namespace Application.Features.LoanTransactions.Commands.Update;

public class UpdatedLoanTransactionResponse : IResponse
{
    public Guid Id { get; set; }
    public Guid MemberId { get; set; }
    public Guid BookId { get; set; }
    public bool ReturnStatus { get; set; }
    public DateTime ReturnTime { get; set; }
}