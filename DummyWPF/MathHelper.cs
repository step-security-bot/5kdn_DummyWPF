namespace DummyWPF;

public interface IMathHelper {
    int Add( int a, int b );
    int Sub( int a, int b );
}

public class MathHelper : IMathHelper {
    public int Add( int a, int b ) => a + b;

    public int Sub( int a, int b ) => a - b;
}