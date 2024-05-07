using NArchitecture.Core.Application.Responses;

namespace Application.Features.LoanTransactions.Commands.Create;

public class CreatedLoanTransactionResponse : IResponse
{
    public Guid Id { get; set; }
    public Guid MemberId { get; set; }
    public Guid BookId { get; set; }
    public bool ReturnStatus { get; set; }
    public DateTime ReturnTime { get; set; }
}