namespace MySunday
{
    public static class Day
    {
        public static async Task Start()
        {
            System.Diagnostics.Stopwatch timer = new();
            
            Console.WriteLine($"Start Day");
            timer.Start();

            //Laundry
            Console.WriteLine("Start Laundry");
            var laundryRoom = new LaundryRoom();
            Laundry dirtyLaundry = new();

            Laundry cleanLaundry = await laundryRoom.WashLaundry(dirtyLaundry);
            Laundry dryLaundry = await laundryRoom.DryLaundry(cleanLaundry);
            await laundryRoom.FoldLaundry(dryLaundry);
            Console.WriteLine("Laundry done");

            //Dishes
            Console.WriteLine("Start Dishes");
            var kitchen = new Kitchen();
            Dishes dishes = new();
            Dishes cleanDishes = await kitchen.StartDishwasher(dishes);
            await kitchen.PutDishesAway(cleanDishes);
            Console.WriteLine("Dishes done");

            //Lawn
            Lawn lawn = new();
            await lawn.Mow();

            //Homework
            Kid rajan = new("Rajan");
            Kid avleen = new("Avleen");
            await rajan.Homework();
            await avleen.Homework();

            //Finished
            timer.Stop();
            Console.WriteLine($"Day finished in {(float)((float)timer.ElapsedMilliseconds / (float)1000)} hours, time for a drink");
        }
    }
}
