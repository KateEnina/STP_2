﻿using System;
using System.Collections.Generic;

namespace Converter {
	public class History {
		public struct Record {
			private int p1;
			private int p2;
			private string number1;
			private string number2;
			public Record(int p1, int p2, string n1, string n2) {
				this.p1 = p1;
				this.p2 = p2;
				number1 = n1;
				number2 = n2;
			}
			public List<string> ToList() {
				return new List<string> { p1.ToString(), number1, p2.ToString(), number2 };
			}
		}

		List<Record> L;
		public void AddRecord(int p1, int p2, string n1, string n2) {
			Record NewRecord = new Record(p1, p2, n1, n2);
			L.Add(NewRecord);
		}

		public Record this[int i] {
			get {
				if (i < 0 || i >= L.Count)
					throw new IndexOutOfRangeException();
				return L[i];
			}
			set {
				if (i < 0 || i >= L.Count)
					throw new IndexOutOfRangeException();
				L[i] = value;
			}
		}

		public void Clear() {
			L.Clear();
		}

		public int Count() {
			return L.Count;
		}

		public History() {
			L = new List<Record>();
		}
	}
}
