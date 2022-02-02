namespace get_set.models
{
   public class Data
   {
      private int mes;
		public int Mes { 
			get { 
				return mes; 
			}

			set {
				if (value > 0 && value <= 12) {
					mes = value; 
				}
			} 
		}

		public int getMes() {
			return this.mes;
		}
      public void setMes(int mes) {
         if (mes > 0 && mes <= 12) {
            this.mes = mes;
         }
         else {
            throw new ArgumentException("O valor não é valido para o range definido");
         }
      }
   }
}