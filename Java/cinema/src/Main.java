import java.util.Scanner;

public class Main {

    // <12 descuento 30%, >=  18 hasta 25 descuento de 10% y > 25 del 5%


    public static void main(String[] args) {

        var sc = new Scanner(System.in);

        double totalPagar = 0;
        System.out.println("Cuantas personas realizaran la compra");
        int n = sc.nextInt();
        sc.nextLine();
        final int PRECIO_REAL = 8000;


        for (int i = 0; i < n; i++) {
            double descuento = 0;
            double totalUsuario = 0;

            System.out.println("Ingrese el Nombre del usuario");
            String nombreUsuario = sc.nextLine();


            System.out.println("Hola " + nombreUsuario + " Bienvenido a CINE UNIGUAJIRA");


            System.out.println("Cuantas entradas desea");
            int entrada = sc.nextInt();
            sc.nextLine();

            System.out.println("Que edad  tiene");
            int edad = sc.nextInt();
            sc.nextLine(); //Limpiando el espacio en memoria. Se hace siempre despues de pedir un dato de tipo entero


            if (edad < 12) {

                descuento = (entrada * PRECIO_REAL) * 0.30;

            }
            if (edad >= 18 && edad <= 25) {

                descuento = (entrada * PRECIO_REAL) * 0.10;

            }

            if (edad > 25) {

                descuento = (entrada * PRECIO_REAL) * 0.05;
            }

            if(edad >= 13 && edad <= 17){
                descuento = 0;
            }

            totalUsuario = (entrada * PRECIO_REAL)  - descuento;

            System.out.println("Pago " + nombreUsuario +" "+ totalUsuario);

            totalPagar = totalPagar + totalUsuario;

        }

        System.out.println("Total vendido es = " + totalPagar);

    }

}
