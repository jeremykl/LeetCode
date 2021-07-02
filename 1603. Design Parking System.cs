public class ParkingSystem
{
	private int BigParkingSpot;
	private int MediumParkingSpot;
	private int SmallParkingSpot;

	public ParkingSystem(int big, int medium, int small)
	{
		BigParkingSpot = big;
		MediumParkingSpot = medium;
		SmallParkingSpot = small;
	}

	public bool AddCar(int carType)
	{
		switch (carType)
		{
			case 1:
				// Big
				return --BigParkingSpot >= 0;
				break;
			case 2:
				// Med
				return --MediumParkingSpot >= 0;
				break;
			default:
				// Small
				return --SmallParkingSpot >= 0;
				break;
		}
	}
}

/**
 * Your ParkingSystem object will be instantiated and called as such:
 * ParkingSystem obj = new ParkingSystem(big, medium, small);
 * bool param_1 = obj.AddCar(carType);
 */