using System;

public class ItemCheckout
{
    public int CheckoutInvoiceNumber { get; private set; }
    public DateTime CheckoutTime { get; private set; }
    public DateTime? ReturnTime { get; private set; } // Nullable to allow for a not-yet-returned equipment
    public Equipment CheckedOutEquipment { get; private set; }

    public ItemCheckout(Equipment equipment, int invoiceNumber)
    {
        CheckedOutEquipment = equipment;
        CheckoutInvoiceNumber = invoiceNumber;
        CheckoutTime = DateTime.Now; // Sets the checkout time to the current time
        ReturnTime = null; // Initially, the return time is not set
        equipment.IsAvailable = false;
    }

    public void RecordReturn()
    {
        ReturnTime = DateTime.Now; // Sets the return time to the current time
        CheckedOutEquipment.IsAvailable = true;
    }
}
