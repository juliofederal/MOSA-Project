// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

using Mosa.Compiler.Framework;

namespace Mosa.Platform.ARMv6.Instructions
{
	/// <summary>
	/// Stm32 - Store Multiple
	/// </summary>
	/// <seealso cref="Mosa.Platform.ARMv6.ARMv6Instruction" />
	public sealed class Stm32 : ARMv6Instruction
	{
		public override int ID { get { return 656; } }

		internal Stm32()
			: base(1, 3)
		{
		}
	}
}
