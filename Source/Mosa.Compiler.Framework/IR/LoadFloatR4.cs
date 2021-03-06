// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

namespace Mosa.Compiler.Framework.IR
{
	/// <summary>
	/// LoadFloatR4
	/// </summary>
	/// <seealso cref="Mosa.Compiler.Framework.IR.BaseIRInstruction" />
	public sealed class LoadFloatR4 : BaseIRInstruction
	{
		public override int ID { get { return 64; } }

		public LoadFloatR4()
			: base(2, 1)
		{
		}

		public override bool IsMemoryRead { get { return true; } }
	}
}
