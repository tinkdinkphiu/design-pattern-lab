public class Main {
    public static void main(String[] args) {
        System.out.println("Multithread Synchronized");

        final int N = 10;

        for (int i = 0; i < 10; i++) {
            Thread thread = new Thread(new Runnable() {
                @Override
                public void run() {
                    for (int j = 0; j < N; j++) {
                        Logger.getInstance().log("Logging from thread " + Thread.currentThread().getId() + " at iteration " + j);
                        try {
                            System.out.println(Thread.currentThread() + " is sleeping");
                            Thread.sleep(1000);
                        } catch (InterruptedException e) {
                            e.printStackTrace();
                        }
                    }
                }
            });
            thread.start();
        }
    }
}