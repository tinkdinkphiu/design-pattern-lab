public class Main {
    public static void main(String[] args) {
        System.out.println("Multithread");

        final int N = 10;

        for (int i = 0; i < 10; i++) {
            Thread thread = new Thread(new Runnable() {
                @Override
                public void run() {
                    for (int j = 0; j < N; j++) {
                        Logger.getInstance().log("Logging from thread " + Thread.currentThread().getId());
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

        // Khi không đồng bộ thì có thể dẫn đến việc tạo ra nhiều instance Logger khi đa
        // luồng vì có thể truy cập vào getInstance() cùng lúc, điều này vi phạm nguyên
        // tắc thiết kế singleton
    }
}