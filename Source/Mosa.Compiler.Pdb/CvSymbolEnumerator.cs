﻿// Copyright (c) MOSA Project. Licensed under the New BSD License.

using System;
using System.Collections.Generic;
using System.IO;

namespace Mosa.Compiler.Pdb
{
	/// <summary>
	/// Enumerator for CodeView symbols in a PDB file.
	/// </summary>
	internal abstract class CvSymbolEnumerator : IEnumerable<CvSymbol>
	{
		#region Data Members

		/// <summary>
		/// Holds the pdb stream, that contains the symbol information.
		/// </summary>
		private PdbStream stream;

		#endregion Data Members

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="CvSymbolEnumerator"/> class.
		/// </summary>
		/// <param name="stream">The stream holding the pdb symbols.</param>
		/// <exception cref="System.ArgumentNullException"><paramref name="stream"/> is null.</exception>
		public CvSymbolEnumerator(PdbStream stream)
		{
			if (stream == null)
				throw new ArgumentNullException(@"stream");

			this.stream = stream;
		}

		#endregion Construction

		#region Methods

		protected abstract bool IsComplete(object state);

		protected abstract object Prepare(BinaryReader reader);

		#endregion Methods

		#region IEnumerable<CvSymbol> Members

		public IEnumerator<CvSymbol> GetEnumerator()
		{
			var cvStream = new CvStream(stream);

			using (var reader = new BinaryReader(cvStream))
			{
				object state = Prepare(reader);

				do
				{
					// Read the len+id of the symbol
					long startPos = cvStream.Position;
					var symbol = CvSymbol.Read(reader);
					yield return symbol;

					// Skip to the next 4 byte boundary
					CvUtil.PadToBoundary(reader, 4);

					long nextPos = startPos + symbol.Length + 2;
					if (nextPos < cvStream.Length)
					{
						// Move to the next symbol
						cvStream.Seek(nextPos, SeekOrigin.Begin);
					}
					else
					{
						break;
					}
				}
				while (!IsComplete(state));
			}
		}

		#endregion IEnumerable<CvSymbol> Members

		#region IEnumerable Members

		/// <summary>
		/// Returns an enumerator that iterates through a collection.
		/// </summary>
		/// <returns>
		/// An <see cref="T:System.Collections.IEnumerator"/> object that can be used to iterate through the collection.
		/// </returns>
		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		#endregion IEnumerable Members
	}
}
