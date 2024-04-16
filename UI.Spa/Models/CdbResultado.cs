namespace Models
{
    /// <summary>
    /// Resultado de Aplica��o CDB
    /// </summary>
    public class CdbResultado
    {
        /// <summary>
        /// Valor total original do resgate.
        /// </summary>
        public decimal ValorResgate { get; set; }

        /// <summary>
        /// Valor bruto do redimento
        /// </summary>
        public decimal RendimentoBruto { get; set; }
        
        /// <summary>
        /// Valor liquido do redimento
        /// </summary>
        public decimal RendimentoLiquido { get; set; }
    }
}
