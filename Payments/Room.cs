using System;

namespace Payments
{
  public class Room
  {
    public int Seats { get; set; }
    private int seatsInUse = 0;

    public Room(int seats)
    {
      Seats = seats;
    }

    public void ReservedSeat()
    {
      seatsInUse++;
      if (seatsInUse >= Seats)
      {
        OnRoomSoldOut(EventArgs.Empty);
      }
      else
      {
        Console.WriteLine("Assento Reservado");
      }
    }


    // Event
    public event EventHandler RoomSoldOutEvent;

    public virtual void OnRoomSoldOut(EventArgs e)
    {
      EventHandler handler = RoomSoldOutEvent;
      handler?.Invoke(this, e);
    }

  }
}