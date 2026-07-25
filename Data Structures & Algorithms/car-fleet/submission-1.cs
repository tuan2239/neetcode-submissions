public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int fleet = 0;
        var leng = position.Length;
        var cars = new(int position, int speed)[leng];
        for (int i = 0; i < leng; i++) {
            cars[i] = (position[i], speed[i]);
        }

        Array.Sort(cars, (car1, car2) => car2.position.CompareTo(car1.position));
        double[] time = new double[leng];
        for (int i = 0; i < leng; i++) {
            time[i] = (double)(target - cars[i].position) / cars[i].speed;
        }

        double prevCarTime = 0;
        for (int i = 0; i < leng; i++) {
            if (time[i] > prevCarTime) {
                fleet++;
                prevCarTime = time[i];
            }
        }
        return fleet;
    }
}
