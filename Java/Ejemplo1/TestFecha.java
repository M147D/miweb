import java.util.Scanner;

public class TestFecha {
	private static Scanner read = new Scanner(System.in);

	public static void main(String[] args) {
		// Usuario ingresa datos de fecha 1
		System.out.println("Ingrese Fecha1 (dia, mes y anio): ");
		int dia = read.nextInt();
		int mes = read.nextInt();
		int anio = read.nextInt();

		// Creación del objeto de la clase Fecha
		Fecha f1 = new Fecha(dia, mes, anio);

		// Usuario ingresa datos de fecha 2
		System.out.println("Ingrese Fecha2 (dia/mes/anio): ");
		String fecha2 = read.next();
		// Creación del objeto de la clase Fecha
		Fecha f2 = new Fecha(fecha2);

		/*// Acceso individual gracias a los setters y getters
		System.out.println("Dia=" + f1.getDia());
		System.out.println("Mes=" + f1.getMes());
		System.out.println("Anio=" + f1.getAnio());
		
		System.out.println("Dia=" + f2.getDia());
		System.out.println("Mes=" + f2.getMes());
		System.out.println("Anio=" + f2.getAnio());*/

		// Se obtiene resultado gracias a la sobreescritura del metodo
		// toString en la Clase Fecha
		System.out.println(f1);
		System.out.println(f2);
		
		if (f1.equals(f2)) {
			System.out.println("Son iguales! ");
		} else {
			System.out.println("Son distintas...");
		}

	}
}
