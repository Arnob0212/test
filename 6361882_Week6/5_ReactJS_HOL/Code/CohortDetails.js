import styles from './CohortDetails.module.css';

function CohortDetails(props) {
  const { cohort } = props;
  const headingStyle = {
  color: cohort.currentStatus.trim().toLowerCase() === 'ongoing' ? 'green' : 'blue'
};


  return (
    <div className={styles.box}>
      <h3 style={headingStyle}>
        <strong>{cohort.cohortCode}</strong> - {cohort.technology}
      </h3>
      <dl>
        <dt>Started On</dt>
        <dd>{cohort.startDate}</dd>
        <dt>Current Status</dt>
        <dd>{cohort.currentStatus}</dd>
        <dt>Coach</dt>
        <dd>{cohort.coachName}</dd>
        <dt>Trainer</dt>
        <dd>{cohort.trainerName}</dd>
      </dl>
    </div>
  );
}

export default CohortDetails;
