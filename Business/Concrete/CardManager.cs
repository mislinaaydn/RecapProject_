using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccsess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CardManager : ICardService
    {
        ICardDal _cardDal;

        public CardManager(ICardDal cardDal)
        {
            _cardDal = cardDal;
        }
        public IResult Add(Card card)
        {
              _cardDal.Add(card);
            return new SuccessResult(Messages.CardAdded);
        }

        public IDataResult<List<Card>> GetByCustomerId(int customerId)
        {
            throw new NotImplementedException();
        }
    }
}
