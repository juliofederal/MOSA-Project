// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

using Mosa.Compiler.Framework;

namespace Mosa.Platform.ARMv6.Instructions
{
	/// <summary>
	/// Dmb32 - Data Memory Barrier
	/// </summary>
	/// <seealso cref="Mosa.Platform.ARMv6.ARMv6Instruction" />
	public sealed class Dmb32 : ARMv6Instruction
	{
		public override int ID { get { return 625; } }

		internal Dmb32()
			: base(1, 3)
		{
		}
	}
}
