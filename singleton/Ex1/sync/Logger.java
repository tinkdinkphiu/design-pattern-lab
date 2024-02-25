import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.Random;

public class Logger {
    private Logger() {
        
    }

    private static Logger uniqueInstance;

    public static Logger getInstance() {
        if (uniqueInstance == null) {
            synchronized (Logger.class) {
                if (uniqueInstance == null) {
                    uniqueInstance = new Logger();
                }
            }
        }
        return uniqueInstance;
    }

    public void log(String message) {
        synchronized (this) {
            try (PrintWriter out = new PrintWriter(new FileWriter("log.txt", true))) {
                out.println(message);
            } catch (IOException e) {
                System.err.println("Error: " + e.getMessage());
            }
        }
    }
}