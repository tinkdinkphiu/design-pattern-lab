import java.util.List;

public class SelectionSort implements SortingStrategy {
    public void sort(List<Integer> list) {
        for (int i = 0; i < list.size() - 1; i++) {
            int minIndex = i;

            for (int j = i + 1; j < list.size(); j++) {
                if (list.get(j) > list.get(minIndex)) {
                    minIndex = j;
                }
            }

            if (minIndex != i) {
                swap(list, i, minIndex);
            }
        }
    }

    private void swap(List<Integer> list, int i, int j) {
        int temp = list.get(i);
        list.set(i, list.get(j));
        list.set(j, temp);
    }
}
