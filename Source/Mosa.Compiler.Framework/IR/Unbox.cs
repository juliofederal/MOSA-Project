// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

namespace Mosa.Compiler.Framework.IR
{
	/// <summary>
	/// Unbox
	/// </summary>
	/// <seealso cref="Mosa.Compiler.Framework.IR.BaseIRInstruction" />
	public sealed class Unbox : BaseIRInstruction
	{
		public override int ID { get { return 182; } }

		public Unbox()
			: base(2, 1)
		{
		}

		public override bool IsMemoryWrite { get { return true; } }

		public override bool IsMemoryRead { get { return true; } }
	}
}
