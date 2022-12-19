import { Button, Container, Table } from 'react-bootstrap';
import React, { useState, useEffect } from 'react';
import { divide, findAll } from '../services/fruits';
import MyModal from '../components/MyModal';

function Home() {

  const [fruits, setFruits] = useState();
  const [idFruit, setIdFruit] = useState();

  const [showModal, setShowModal] = useState(false);

  const handleClick = (id) => {
    setShowModal(true)
    setIdFruit(id)
  }

  const findAllFruits = async () => {
    const res = await findAll();
    setFruits(res.data);
  }

  useEffect(() => {
    findAllFruits();
  }, []);

  return (
    <>
      <Container className="text-center my-5">
        {fruits == null ?
          <>
            <h1 className="text-align-center"> Sem registros </h1>
            <p> Inicie a api para buscar os dados </p>
          </>
          :
          <Table striped bordered hover size="sm">
            <thead>
              <tr>
                <th>Descrição</th>
                <th>A</th>
                <th>B</th>
                <th>Acão</th>
              </tr>
            </thead>
            <tbody>
              {fruits.map(item => (
                <tr key={item.id}>
                  <td>{item.description}</td>
                  <td>{item.valueA}</td>
                  {<td>{item.valueB}</td>}
                  <td>
                    <Button variant="primary"
                      onClick={() => handleClick(item.id)}
                    >
                      Selecionar
                    </Button>
                  </td>
                </tr>
              ))}
            </tbody>
          </Table>
        }

        {idFruit && (
          <MyModal
            idFruit={idFruit}
            showModal={showModal}
            setShowModal={setShowModal}
          />
        )}
      </Container>
    </>
  );
}

export default Home;
