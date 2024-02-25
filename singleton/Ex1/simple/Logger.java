import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;

public class Logger {
    private Logger() {

    }

    private static Logger uniqueInstance;

    public static Logger getInstance() {
        if (uniqueInstance == null) {
            uniqueInstance = new Logger();
        }
        return uniqueInstance;
    }

    public void log(String message) {
        try (PrintWriter out = new PrintWriter(new FileWriter("log.txt", true))) {
            out.println(message);
        } catch (IOException e) {
            System.err.println("Error: " + e.getMessage());
        }
    }
}