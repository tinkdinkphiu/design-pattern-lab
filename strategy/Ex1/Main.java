import java.util.ArrayList;

public class Main {
    public static void main(String[] args) {
        ArrayList<Integer> unsortedArray = new ArrayList<>();
        unsortedArray.add(5);
        unsortedArray.add(75);
        unsortedArray.add(56);
        unsortedArray.add(9);
        unsortedArray.add(32);
        unsortedArray.add(22);
        unsortedArray.add(17);
        unsortedArray.add(23);
        unsortedArray.add(63);
        unsortedArray.add(8);


        System.out.println("Original array: " + unsortedArray.toString());

        SortedList sortedList = new SortedList();

        ArrayList<Integer> cloneArray = unsortedArray;
        sortedList.setStrategySort(new BubbleSort());
        sortedList.performSort(cloneArray);
        System.out.println("Bubble sort: " + cloneArray.toString());

        cloneArray = unsortedArray;
        sortedList.setStrategySort(new InsertionSort());
        sortedList.performSort(cloneArray);
        System.out.println("Insertion sort: " + cloneArray.toString());

        cloneArray = unsortedArray;
        sortedList.setStrategySort(new SelectionSort());
        sortedList.performSort(cloneArray);
        System.out.println("Selection sort: " + cloneArray.toString());
    }
}