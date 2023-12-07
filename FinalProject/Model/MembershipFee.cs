using System;

public class MembershipFee
{
    private static int invoiceCounter = 1000000;

    public decimal Fee { get; private set; }
    public DateTime PaymentDateTime { get; private set; }
    public int InvoiceNumber { get; private set; }
   
    public MembershipFee(int age)
    {
        Fee = CalculateFee(age);
        PaymentDateTime = DateTime.Now; // Set the payment date and time to current.
        InvoiceNumber = GenerateInvoiceNumber();
    }

    public static decimal CalculateFee (int age)
    {
        if(age >= 6 && age <= 12)
        {
            return 50;
        }
        if (age >= 12 && age <= 18)
        {
            return 70;
        }
        else
        {
            return 100;
        }
    }
    private static int GenerateInvoiceNumber()
    {
        return ++invoiceN; // Increment and return the next invoice number.
    }
}
