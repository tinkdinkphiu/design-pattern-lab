import java.util.ArrayList;
import java.util.List;

public class SortedList {
    private List<Integer> list = new ArrayList<>();
    private SortingStrategy sortingStrategy;

    public void setSortingStrategy(SortingStrategy sortingStrategy) {
        this.sortingStrategy = sortingStrategy;
    }

    public void add(int number) {
        list.add(number);
    }

    public void sort() {
        sortingStrategy.sort(list);
    }

    public void printList() {
        for (int number : list) {
            System.out.print(number + " ");
        }
        System.out.println();
    }
}