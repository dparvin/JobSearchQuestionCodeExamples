#pragma once
using namespace System;
using namespace System::Collections::Generic;
using namespace System::Linq;

public ref class TheaterSeats
{
public:
	static array<int>^ AssignSeats(array<int>^% seatAssign, array<int>^ seatsRequested);
private:
	static int FindNextAvailableSeat(List<int>^ usedSeats, int seat);
};
