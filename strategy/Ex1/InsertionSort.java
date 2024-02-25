import java.util.ArrayList;

public class InsertionSort implements IStrategySort {
    @Override
    public void sort(ArrayList<Integer> data) {
        for (int i = 1; i < data.size(); i++) {
            int current = data.get(i);
            int j = i - 1;
            while (j >= 0 && data.get(j) > current) {
                data.set(j + 1, data.get(j));
                j = j - 1;
            }
            data.set(j + 1, current);
        }
    }
}