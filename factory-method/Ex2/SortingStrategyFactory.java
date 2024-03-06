public class SortingStrategyFactory {
    public SortingStrategy createSortingStrategy(String strategyType) {
        switch (strategyType) {
            case "quick":
                return new QuickSort();
            case "insertion":
                return new InsertionSort();
            case "selection":
                return new SelectionSort();
            default:
                throw new IllegalArgumentException("Invalid sorting strategy type");
        }
    }
}
