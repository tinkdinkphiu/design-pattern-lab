public class Main {
    public static void main(String[] args) {
        SortedList list = new SortedList();
        list.add(2);
        list.add(15);
        list.add(92);
        list.add(64);
        list.add(22);
        list.add(35);
        list.add(54);
        list.add(87);
        list.add(12);

        SortingStrategyFactory strategyFactory = new SortingStrategyFactory();

        SortingStrategy quickSortStrategy = strategyFactory.createSortingStrategy("quick");
        list.setSortingStrategy(quickSortStrategy);
        list.sort();
        list.printList();

        SortingStrategy insertionSortStrategy = strategyFactory.createSortingStrategy("insertion");
        list.setSortingStrategy(insertionSortStrategy);
        list.sort();
        list.printList();

        SortingStrategy selectionSortStrategy = strategyFactory.createSortingStrategy("selection");
        list.setSortingStrategy(selectionSortStrategy);
        list.sort();
        list.printList();
    }
}
