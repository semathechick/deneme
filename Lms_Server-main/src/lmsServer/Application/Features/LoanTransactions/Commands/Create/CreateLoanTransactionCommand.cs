using Application.Features.LoanTransactions.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Pipelines.Logging;
using NArchitecture.Core.Application.Pipelines.Transaction;
using MediatR;

namespace Application.Features.LoanTransactions.Commands.Create;

public class CreateLoanTransactionCommand : IRequest<CreatedLoanTransactionResponse>, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid MemberId { get; set; }
    public Guid BookId { get; set; }
    public bool ReturnStatus { get; set; }
    public DateTime ReturnTime { get; set; }

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetLoanTransactions"];

    public class CreateLoanTransactionCommandHandler : IRequestHandler<CreateLoanTransactionCommand, CreatedLoanTransactionResponse>
    {
        private readonly IMapper _mapper;
        private readonly ILoanTransactionRepository _loanTransactionRepository;
        private readonly LoanTransactionBusinessRules _loanTransactionBusinessRules;

        public CreateLoanTransactionCommandHandler(IMapper mapper, ILoanTransactionRepository loanTransactionRepository,
                                         LoanTransactionBusinessRules loanTransactionBusinessRules)
        {
            _mapper = mapper;
            _loanTransactionRepository = loanTransactionRepository;
            _loanTransactionBusinessRules = loanTransactionBusinessRules;
        }

        public async Task<CreatedLoanTransactionResponse> Handle(CreateLoanTransactionCommand request, CancellationToken cancellationToken)
        {
            LoanTransaction loanTransaction = _mapper.Map<LoanTransaction>(request);

            await _loanTransactionRepository.AddAsync(loanTransaction);

            CreatedLoanTransactionResponse response = _mapper.Map<CreatedLoanTransactionResponse>(loanTransaction);
            return response;
        }
    }
}