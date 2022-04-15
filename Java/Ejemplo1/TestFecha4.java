import java.util.*;

public class TestFecha4 {
    static Scanner read = new Scanner(System.in);
    public static void main(String[] args) {
        
        System.out.println("Ingrese Fecha (dd/mm/aaaa): ");
        String sFecha = read.nextLine();

        Fecha f = new Fecha(sFecha);

        System.out.println("La ingresada es: "+f.toString());

        System.out.println("Ingrese dias a sumar: ");
        int diasSum = read.nextInt();

        f.addDias(diasSum);

        System.out.println("sumando "+diasSum+" dias, queda: "+ f);
    }
}
