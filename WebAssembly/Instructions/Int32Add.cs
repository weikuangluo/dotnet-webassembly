namespace WebAssembly.Instructions
{
	/// <summary>
	/// Sign-agnostic addition.
	/// </summary>
	public class Int32Add : SimpleInstruction
	{
		/// <summary>
		/// Always <see cref="OpCode.Int32Add"/>.
		/// </summary>
		public sealed override OpCode OpCode => OpCode.Int32Add;

		/// <summary>
		/// Creates a new  <see cref="Int32Add"/> instance.
		/// </summary>
		public Int32Add()
		{
		}
	}
}