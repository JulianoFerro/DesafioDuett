import React, { useState, useEffect } from 'react';
import { Button, Modal, Form, FloatingLabel } from 'react-bootstrap';
import { findById, multiply, divide } from '../services/fruits'

function MyModal(props) {

  const [fruit, setFruit] = useState();
  const [result, setResult] = useState(0);
  const { idFruit, showModal, setShowModal } = props

  useEffect(() => {
    findFruitById();
  }, [idFruit]);

  const findFruitById = async () => {
    const res = await findById(idFruit);
    setFruit(res.data);
  }

  const divideFruit = async () => {
    const res = await divide(idFruit);
    setResult(res.data);
  }

  const multiplyFruit = async () => {
    const res = await multiply(idFruit);
    setResult(res.data);
  }

  const handleClose = () => {
    setShowModal(false)
    setResult(0);
  }

  return (
    <>
      <Modal show={showModal} onHide={handleClose}>
        <Modal.Header closeButton>
          <Modal.Title>Título Inteligente</Modal.Title>
        </Modal.Header>
        <Modal.Body>

          <FloatingLabel controlId="floatingInput" label={fruit?.description}>
            <Form.Control type="text" disabled />
          </FloatingLabel>

          <FloatingLabel controlId="floatingInput" label={fruit?.valueA}>
            <Form.Control type="text" disabled />
          </FloatingLabel>

          <FloatingLabel controlId="floatingInput" label={fruit?.valueB}>
            <Form.Control type="text" disabled />
          </FloatingLabel>

          {result > 0 ?
            <FloatingLabel controlId="floatingInput" label={result} >
              <Form.Control type="text" disabled />
            </FloatingLabel> : null
          }

        </Modal.Body>
        <Modal.Footer>
          <Button onClick={multiplyFruit} className="me-2" variant="primary" type="submit">
            Multiplicar
          </Button>
          <Button onClick={divideFruit} className="me-2" variant="primary" type="submit">
            Dividir
          </Button>
        </Modal.Footer>
      </Modal>
    </>
  );
}

export default MyModal;
