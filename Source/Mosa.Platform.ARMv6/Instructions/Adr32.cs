// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

using Mosa.Compiler.Framework;

namespace Mosa.Platform.ARMv6.Instructions
{
	/// <summary>
	/// Adr32 - Form PC-relative Address
	/// </summary>
	/// <seealso cref="Mosa.Platform.ARMv6.ARMv6Instruction" />
	public sealed class Adr32 : ARMv6Instruction
	{
		public override int ID { get { return 614; } }

		internal Adr32()
			: base(1, 3)
		{
		}
	}
}
