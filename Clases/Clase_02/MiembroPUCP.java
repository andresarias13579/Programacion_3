abstract class MiembroPUCP extends Miembro implements IConsultable {
	private String codigoPUCP;
	public MiembroPUCP(String nombre, Date fechaNacimiento, String direccion, String email,
		char sexo, String codigoPUCP){
		super (nombre, fechaNacimiento, direccion, email, sexo);
		this.codigoPUCP = codigoPUCP;
	}
}