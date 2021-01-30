# DesafioTecnicoDeliverIT
Desafio Técnico Deliver IT

Requisições:
  Em um programa como o Postman execute as chamadas:

  GET:
    https://localhost:<porta>/ContaAPagar
    
  POST:
    https://localhost:<porta>/ContaAPagar
    O content-type deve ser json.
    No body da requisição adicione:
      {
        "Nome": "Teste",
        "ValorOriginal": 100.50,
        "DataVencimento": "10/01/2021",
        "DataPagamento": "20/01/2021"
      }
