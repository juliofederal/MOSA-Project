// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

using Mosa.Compiler.Framework;

namespace Mosa.Platform.ARMv6.Instructions
{
	/// <summary>
	/// Mul32
	/// </summary>
	/// <seealso cref="Mosa.Platform.ARMv6.ARMv6Instruction" />
	public sealed class Mul32 : ARMv6Instruction
	{
		internal Mul32()
			: base(1, 3)
		{
		}

		protected override void Emit(InstructionNode node, ARMv6CodeEmitter emitter)
		{
			EmitMultiplyInstruction(node, emitter);
		}
	}
}
