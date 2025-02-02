﻿using Domain.Entities.Payments.Enums;
using Domain.Entities.Payments.ObjectValues;

namespace Domain.Entities.Payments;

public abstract class Payment
{
    public int Id { get; protected set; }
    public string Ssn { get; protected set; } = string.Empty;
    public decimal Amount { get; protected set; }
    public PaymentMethodObjectValue PaymentMethodObjectValue { get; protected set; } = new();

    public Guid? CreditCardId { get; protected set; }
    public CreditCard? CreditCard { get; protected set; }

    public Guid? DebitCardId { get; protected set; }
    public DebitCard? DebitCard { get; protected set; }

    public void SetId(int id) => Id = id;
    public void SetSsn(string ssn) => Ssn = ssn;
    public void SetAmount(decimal amount) => Amount = amount;
    public abstract void DefaultPayment(EPaymentMethod ePaymentMethod);
    public void SetPaymentMethodObjectValue(PaymentMethodObjectValue value) =>
        PaymentMethodObjectValue = value;

    public void SetCreditCard(CreditCard creditCard)
    {
        CreditCard = creditCard;
        CreditCardId = creditCard.Id;
    }

    public void SetDebitCard(DebitCard debitCard)
    {
        DebitCard = debitCard;
        DebitCardId = debitCard.Id;
    }
}