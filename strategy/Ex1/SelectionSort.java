import java.util.ArrayList;

public class SelectionSort implements IStrategySort {
    @Override
    public void sort(ArrayList<Integer> data) {
        for (int i = 0; i < data.size() - 1; i++) {
            int index = i;
            for (int j = i + 1; j < data.size(); j++)
                if (data.get(j) < data.get(index)) 
                    index = j;

            int smallerNumber = data.get(index);  
            data.set(index, data.get(i));
            data.set(i, smallerNumber);
        }
    }
}