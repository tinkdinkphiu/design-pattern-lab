import java.util.ArrayList;

public class SortedList {
    private IStrategySort strategySort;

    public void setStrategySort(IStrategySort strategySort) {
        this.strategySort = strategySort;
    }

    public void performSort(ArrayList<Integer> data) {
        this.strategySort.sort(data);
    }
}