public class Fecha 
{
	private int dia;
	private int mes;
	private int anio;
	
	//Constructor 1
	public Fecha(int d, int m, int a) {
		dia = d;
		mes = m;
		anio = a;
	}
	
	//Constructor 2: se usa para admitir mas de una forma
	//de crear objetos=sobrecarga de metodos
	public Fecha(String s){
		int pos1 = s.indexOf('/');
		
		int pos2 = s.lastIndexOf('/');
		
		String sDia = s.substring(0,pos1);
		dia = Integer.parseInt(sDia);
		
		String sMes = s.substring(pos1+1,pos2);
		mes = Integer.parseInt(sMes);
		
		String sAnio = s.substring( pos2+1);
		anio =Integer.parseInt(sAnio);		
	}
		
	@Override//sobrescritura de metodo
	public String toString() {
		return dia+"/"+mes+"/"+anio;
	}
	
	@Override//sobrescritura de metodo
	public boolean equals(Object obj) {
		// TODO Auto-generated method stub
		Fecha otra = (Fecha) obj;
		return (dia==otra.dia) && (mes==otra.mes) && (anio==otra.anio);
	}
	
	public int getDia() {
		return dia;
	}
	public void setDia(int dia) {
		this.dia = dia;
	}
	public int getMes() {
		return mes;
	}
	public void setMes(int mes) {
		this.mes = mes;
	}
	public int getAnio() {
		return anio;
	}
	public void setAnio(int anio) {
		this.anio = anio;
	}	
	
}
