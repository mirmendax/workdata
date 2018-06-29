namespace WorkData.DataLib{
	
	[Serializable]
	public class Generator {
		string TypeGenerator  = string.Empty;
		bool Oldnew = false;//true - новый false - старый
		float Sn = 0.0f;//Snom
		float Pn = 0.0f;
		float Pu = 0.0f;//P установленная
		float Qn = 0.0f;
		float cosPH = 0.9;
		
		float Ug = 13.8f;// Stator
		float Ig = 0.0f;// Stator
		float Uf = 0.0f;//rotor
		float If = 0.0f;//rotor
		TransU TN1 = new TransU("TH1", "Type", 13800, 100);
		TransU TN2 = new TransU("TH2", "Type", 13800, 100);
		TransU TN3 = new TransU("TH3", "Type", 13800, 100);
		TransI TT1 = new TransI("TT", "Type", 8000, 5);
		
	}
	[Serializable]
	public class TransU {
		string Name = "";//TH1, TH2, TH3
		string Type = "";
		float Un1 = 0.0f;
		float Un2 = 0.0f;
		float kTrans = 0.0f;
		
		public TransU(string _name, string _type, float _un1, float _un2, float _ktrans = 0){
			 this.Name = _name;
			 this.Type = _type;
			 this.Un1 = _un1;
			 this.Un2 = _un2;
			 if (_ktrans = 0) this.kTrans = Un1/Un2; else this.kTrans = _ktrans;
		}
		
	}
	[Serializable]
	public class TransI {
		string Name = "";//TH1, TH2, TH3
		string Type = "";
		float In1 = 0.0f;
		float In2 = 0.0f;
		float kTrans = 0.0f;
		
		public TransI(string _name, string _type, float _in1, float _in2, float _ktrans = 0){
			 this.Name = _name;
			 this.Type = _type;
			 this.In1 = _in1;
			 this.In2 = _in2;
			 if (_ktrans = 0) this.kTrans = In1/In2; else this.kTrans = _ktrans;
		}
	}
	
	[Serializable]
	public class SV{
		string IndustrialNumber = "";
		DateTime DataVvoda = DateTime.Now;
		bool XN1 = false;
		string Type = "STS-2P";
		
		byte AB = 1;//1-4 ЩПТ
		string FU = "1FU10";//предохранитель НВ на ЩПТ
		
		byte Block = 1;//1-9T
		
		Dictionary<float, float> OPR = new Dictionary<float, float>(6);
		Dictionary<float, float> OPS = new Dictionary<float, float>(6);
		Dictionary<float, float> OMV0_8 = new Dictionary<float, float>(5);
		Dictionary<float, float> OMV1_0 = new Dictionary<float, float>(5);
		Dictionary<float, float> OMV1_1 = new Dictionary<float, float>(5);
		
		string Ver_ARV = "";
		string Ver_Link = "";
		string Ver_Display = "";
		string Ver_LogView = "";
		string Ver_BMTZ = "";
		
		BT BT_Trans = new BT();
		
	}
	[Serializable]
	 public class BT{
		 string Type = "ТСЗП-4000/20ВУ3";
		 string IndustrialNumber = "";
		 DateTime DateVVoda = DateTime.Now;
		 string WindingConnection = "Y/Δ-11";//соединение обмоток
		 string IP = "IP21";
		 float U1 = 13800;
		 float I1 = 150;
		 float U2 = 902;
		 float I2 = 2300;
		 float Ukz = 6.0;
		 float Sn = 3593;
		 float Weight = 11500;
		 
	 }
	
	}
	[Serializable]
	public class Defect{
		DateTime Date = DateTime.Now;
		string Info = "";
		
	}
	[Serializable]
	public class Data{
		byte _number = 0;//1-23Г
		Generator _generator = new Generator();
		SV _sv = new SV();
		List<Defect> _defect = new List<Defect>();
		
	}

	
