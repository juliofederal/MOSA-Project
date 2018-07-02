// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

using Mosa.Compiler.Framework;
using Mosa.Compiler.Common;

namespace Mosa.Platform.ARMv6.Instructions
{
	/// <summary>
	/// Add32 - Add
	/// </summary>
	/// <seealso cref="Mosa.Platform.ARMv6.ARMv6Instruction" />
	public sealed class Add32 : ARMv6Instruction
	{
		internal Add32()
			: base(1, 3)
		{
		}

		protected override void Emit(InstructionNode node, ARMv6CodeEmitter emitter)
		{
			EmitDataProcessingInstruction(node, emitter, Bits.b0100);
		}
	}
}
