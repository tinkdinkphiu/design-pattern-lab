import java.util.ArrayList;

public class BubbleSort implements IStrategySort {
    @Override
    public void sort(ArrayList<Integer> data) {
        int n = data.size();
        for (int i = 0; i < n-1; i++)
            for (int j = 0; j < n-i-1; j++)
                if (data.get(j) > data.get(j+1)) {
                    int temp = data.get(j);
                    data.set(j, data.get(j+1));
                    data.set(j+1, temp);
                }
    }
}